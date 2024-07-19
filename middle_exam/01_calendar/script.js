const weekNameList = document.querySelector("#weekList");
const dateList = document.querySelector("#dateList"); //所有天數格子
const copyTemplate = document.querySelector("#colTemplate");
const prevYearBtn = document.querySelector("#prev_year");
const nextYearBtn = document.querySelector("#next_year");
const loginModal = document.querySelector("#loginModal");
const saveBtn = loginModal.querySelector("#save_btn")
const deleteBtn = loginModal.querySelector("#delete_btn")
//抓modal dom //使用bootstrap的Modal類來控制對話關閉
const myModal = document.querySelector("#loginModal")
const modal = new bootstrap.Modal(myModal)
const key = "eventObj";
const inputOfTime = document.querySelector("#datetime"); //時間輸入框
const inputOfThing = document.querySelector("#todoItem"); //行程輸入框
const inputOfColor = document.querySelector("#colorInput");//色彩輸入框
let getStoredEvent;
let todoThingsGrid;
let eventOful;

//初始值
let selectedDate = null;
let selectedTarget = null; // 用於追蹤當前選中的待辦事項
let currYear = 2024
let currMonth = 6
let thisYear = new Date().getFullYear();
let thisMonth = new Date().getMonth();  //idx，起始為0
let thisDay = new Date().getDate();  //idx，起始為0
const monthNames = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December']
const weekNames = ['日', '一', '二', '三', '四', '五', '六'];

const year = document.querySelector("#year");
const monthPicker = document.querySelector("#month_picker");

window.addEventListener("load", () => {
    //月曆建置
    weekNames.forEach((item) => {
        let li = document.createElement("li")
        li.textContent = item
        li.classList.add('week_name')
        weekNameList.appendChild(li)
    });
    ChangeYearMonth()
    makeDayGrid(currYear, currMonth)
    makeEventListItem()

})

prevYearBtn.addEventListener("click", () => {
    currYear--;

    ChangeYearMonth()
    makeDayGrid(currYear, currMonth)
    makeEventListItem()

})
nextYearBtn.addEventListener("click", () => {
    currYear++;
    ChangeYearMonth()
    makeDayGrid(currYear, currMonth)
    makeEventListItem()

})
monthPicker.addEventListener("click", () => {
    currMonth = (currMonth + 1) % 12
    if (currMonth === 0) currYear++; // 如果月份變為 0，則年份加 1
    ChangeYearMonth()
    makeDayGrid(currYear, currMonth)
    makeEventListItem()
})

loginModal.addEventListener("hide.bs.modal", () => {

    deleteBtn.classList.add("d-none")
    saveBtn.classList.remove("d-none")
    selectedTarget = null
})

saveBtn.addEventListener("click", function () {

    const dateTimeInput = document.querySelector("#datetime").value;
    const formattedDateTime = formatDateToLocal(dateTimeInput); // 確保格式化
    const todoItemInput = document.querySelector("#todoItem").value.trim();
    const colorInput = document.querySelector("#colorInput").value;
    if (!todoItemInput) {
        alert('請輸入待辦事項');
        return;
    }
     //轉array並取得線上資料
    const todoList = getTodoListFromStorage()

    if (selectedTarget) {
        //編輯模式
        selectedtarget.datetime = formattedDateTime || formatDateToLocal(Date.now());
        selectedtarget.todoItem = todoItemInput;
        selectedtarget.color = colorInput;

        const index = todoList.findIndex(event => event.id === selectedtarget.id);
        if (index !== -1) {
            todoList[index] = selectedtarget;
        }
    }
    else {
        //新增模式
        const eventObj = {
            id: new Date().valueOf(),
            datetime: formattedDateTime || formatDateToLocal(Date.now()),
            todoItem: todoItemInput,
            color: colorInput,
        }
       
        todoList.push(eventObj)
    }

    //加入新事項  //轉JSON並存回線上
    localStorage.setItem(key, JSON.stringify(todoList));
    alert('已完成存檔');
    makeDayGrid(currYear, currMonth);
    makeEventListItem()
    //保存後，關閉對話
    modal.hide()
})

deleteBtn.addEventListener("click", () => {
    // 取得待刪除的待辦事項 ID
    const todoId = parseInt(deleteBtn.getAttribute('data-id'))
    let todoList = getTodoListFromStorage();
    todoList = todoList.filter(event => event.id !== todoId); // 篩選出不包含指定 id 的待辦事項    
    localStorage.setItem(key, JSON.stringify(todoList)); // 更新 localStorage
    alert('已刪除待辦事項');
    // 重新顯示待辦事項  // 重新生成日曆
    modal.hide()
    makeDayGrid(currYear, currMonth);
    makeEventListItem()
})

//年、月、星期刷新
function ChangeYearMonth() {
    year.textContent = currYear
    monthPicker.textContent = monthNames[currMonth]
};

//取得指定年、月後的天數
function getDaysInMonth(year, monthIdx) {
    return new Date(year, monthIdx + 1, 0).getDate()
};

function makeDayGrid(year, monthIdx) {
    //先清空，標題賦值
    dateList.innerHTML = '';
    //取得當月天數 
    let firstDayOfWeek = new Date(year, monthIdx, 1).getDay()
    let prevMonthDays = getDaysInMonth(year, monthIdx - 1)
    let days = getDaysInMonth(year, monthIdx)
    let daysCount = 1;
    let nextMonthDate = 1;
    // console.log(new Date(year, monthIdx, 1))
    // console.log('索引'+monthIdx+'、第一天在星期' + firstDayOfWeek)   
    // console.log('上個月天數 ' + prevMonthDays)
    // console.log('當月天數 ' + days)
    // console.log('下個月日期' + nextMonthDate)
    // console.log('跳過天數 ' + firstDayOfWeek)

    //產生日期
    //得到一串日期，根據日期做出日期格子
    for (let idx = 1; idx <= 42; idx++) {
        const cloneDateGrid = copyTemplate.content.querySelector("li")
        const dateGrid = cloneDateGrid.cloneNode(true)
        const numOfDateGrid = dateGrid.querySelector("p")
        //星期天開始算
        if (idx <= firstDayOfWeek) {
            // 顯示上個月日期
            numOfDateGrid.textContent = prevMonthDays - firstDayOfWeek + idx
            numOfDateGrid.classList.add('prev_month') //改變上個月的形象
            dateGrid.setAttribute("a_year", `${currYear}`)
            dateGrid.setAttribute("a_month", `${currMonth}`)
            dateGrid.classList.add("prev-month-grid")
        }

        else if (daysCount <= days) {
            // 顯示當月
            // li.querySelector("p").textContent = `${daysCount++}`
            numOfDateGrid.textContent = `${daysCount++}`
            numOfDateGrid.classList.add('current_month')
            dateGrid.setAttribute("a_year", `${currYear}`)
            dateGrid.setAttribute("a_month", `${currMonth + 1}`)
            if(currYear === thisYear && 
               currMonth === thisMonth && parseInt(numOfDateGrid.textContent)===thisDay){
                const todayCircle = document.createElement("span");
                todayCircle.classList.add("today-circle")
                dateGrid.appendChild(todayCircle)
            }


        } else {
            // 顯示下個月
            //li.querySelector("p").textContent = ''
            numOfDateGrid.textContent = nextMonthDate++
            numOfDateGrid.classList.add('next_month')
            dateGrid.setAttribute("a_year", `${currYear}`)
            dateGrid.setAttribute("a_month", `${currMonth + 2}`)
            dateGrid.classList.add("next-month-grid")


        }
        dateGrid.setAttribute('a_date', `${numOfDateGrid.textContent}`)
        //順便對格子掛監聽器
        const addBtn = dateGrid.querySelector(".add_btn");
        addBtn.addEventListener("click", (e) => {
            const dateBox = e.target.closest(".date")
            const year = dateBox.getAttribute("a_year")
            const month = dateBox.getAttribute("a_month") - 1 //將月份轉換為 0 起始的索引
            const date = dateBox.getAttribute("a_date")
            selectedDate = new Date(year, month, date)
            const now = new Date()
            selectedDate.setHours(now.getHours())
            selectedDate.setMinutes(now.getMinutes())
            const datetimeInput = document.querySelector("#datetime");
            datetimeInput.value = formatDateToLocal(selectedDate);

            //清空輸入框
            inputOfThing.value = ''
            inputOfColor.value ='#000000'

            saveBtn.classList.remove("d-none")
            deleteBtn.classList.add("d-none")
            modal.show()
        })

        dateList.append(dateGrid);

    };

};
function formatDateToLocal(date) {
    const newDate = typeof date === 'string' ? new Date(date) : date
    const year = newDate.getFullYear()
    const month = String(newDate.getMonth() + 1).padStart(2, '0')
    const day = String(newDate.getDate()).padStart(2, '0')
    const hours = String(newDate.getHours()).padStart(2, '0')
    const minutes = String(newDate.getMinutes()).padStart(2, '0')


    return `${year}-${month}-${day}T${hours}:${minutes}`
};

//取得雲端資料(key)、轉成物件
function getTodoListFromStorage() {
    const localStorageItem = localStorage.getItem(key)
    return localStorageItem ? JSON.parse(localStorageItem) : [];
}


/*從storage裡拿出資料後因為都是字串，
要foreach(他是陣列)，並對物件內每項資料做出對應處理，讓他變回原始的狀態*/


function makeEventListItem() 
{
    getStoredEvent = getTodoListFromStorage();
    //清空待辦事項
    document.querySelectorAll(".todo_list").forEach(ul => ul.innerHTML = '');
    //對雲端拿下來的資料進行處理
    getStoredEvent.forEach((todoEvent) => {
        // 製作待辦事項的li元素，寫上待辦事項，染色
        const eventListItem = document.createElement("li") 
        const timeOfEvent = new Date(todoEvent.datetime).toLocaleTimeString([],{hour:'2-digit',minute:'2-digit',hour12:false})  
        eventListItem.setAttribute("class","todo-event")
        eventListItem.innerHTML = `<span class="event_time">${timeOfEvent}</span> ${todoEvent.todoItem}`
        eventListItem.style.borderLeft = `5px solid ${todoEvent.color}`
        eventListItem.style.width = `fit-content`

        eventListItem.dataset.id = todoEvent.id //毫秒
        eventListItem.addEventListener("click", function () {

            inputOfTime.value = todoEvent.datetime
            inputOfThing.value = todoEvent.todoItem
            inputOfColor.value = todoEvent.color
            deleteBtn.setAttribute("data-id", todoEvent.id) //刪除鈕ID
            selectedTarget = todoEvent //選中的待辦事項
            modal.show()
            saveBtn.classList.add("d-none")
            deleteBtn.classList.remove("d-none")
            modal.show()
        })

        // 找對應日期的格子
        const gridYear = (new Date(todoEvent.datetime).getFullYear()).toString()
        const gridMonth = (new Date(todoEvent.datetime).getMonth() + 1).toString()
        const gridDate = (new Date(todoEvent.datetime).getDate()).toString()

        //抓待辦事項的ul
        let allGridsUl = document.querySelectorAll(".date");
        allGridsUl.forEach((dateGrid) => {
            const year = dateGrid.getAttribute("a_year");
            const month = dateGrid.getAttribute("a_month");
            const date = dateGrid.getAttribute("a_date");
            if (year === gridYear && month === gridMonth && date === gridDate) {

                dateGrid.appendChild(eventListItem)
            }
        })
    })

}



