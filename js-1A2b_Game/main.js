//1.宣告dom(這些承接tag的變數)，dom的呼叫要早一點，盡量放上面
const startBtn = document.querySelector("#start_btn")
const showAnsBtn = document.querySelector("#show_answer_btn")
const restartBtn = document.querySelector("#restart_btn")
const guessHistoryList = document.querySelector("#guess_history_list")
//2.宣告存取答案的變數
let answer;
const guessInput = document.querySelector("#guess_input")
const guessBtn = document.querySelector("#guess_btn")
const gameMsgToast = document.querySelector("#game_msg_toast")
//方法2 將他放置載入頁面宣告，並傳入Elment(我將方法1先註解)
const toastBootstrap = new bootstrap.Toast(gameMsgToast)
// const toastBootstrap = new bootstrap.Toast(gameMsgToast,{delay:500}) //隱藏 toast 之前的延遲.5秒（以毫秒為單位）。
//const toastBootstrap = new bootstrap.Toast(gameMsgToast,{autohide:false}) //延遲後是否自動隱藏 
//const toastBootstrap = new bootstrap.Toast(gameMsgToast,{animation:false}) //是否對 toast 應用 CSS 淡入淡出過渡。
//其實可以帶第二個參數Options(其實是一個物件) ，也可以在class中做更動
//下方為Bootstrap ▼ 事件使用的練習 (對dom掛上監聽)
// gameMsgToast.addEventListener("hide.bs.toast", () => {
    //     console.log("toast hide!")
    // })
//不做額外宣告，此處因為過關已經寫死，直接抓dom出來就好
const modalBootstrap = new bootstrap.Modal(document.querySelector("#end_game_modal"))

const endGameBtn = document.querySelector("#end_game_btn")

//如果想要一進去就有答案
window.addEventListener("load",()=>{
    initGame()
})
//4.發現相同邏輯，抽出來作方法
function initGame() {
    answer = generateAns()//產出答案 
    guessHistoryList.innerHTML = '' //清空紀錄
}

function generateAns() {
    const numArr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    // numArr.sort((a,b)=>{
    //     return getRandomArbitrary(-1,1)}) //為什麼要有-1,1
    //簡寫▼
    numArr.sort((a,b) => getRandomArbitrary(-1, 1))
    return numArr.slice(0, 4).join("") //取4個數字，並以字串組合
}

function getRandomArbitrary(min, max) {
    return Math.random() * (max - min) + min;
}



//3.為宣告掛上事件監聽器("行為發生時",()=>達成的事情)
startBtn.addEventListener("click", initGame
    //()=>{ 產出答案、清空紀錄} event target
)
restartBtn.addEventListener("click", initGame
    //()=>{ 產出答案、清空紀錄}
);
showAnsBtn.addEventListener("click",()=>
     //console.log(`ans:${answer}`) //測試用
    showHint(`答案是:${answer}`)
);

guessBtn.addEventListener("click", () => {
    //按下猜，要取值
    const val = guessInput.value.trim() //為什麼不是textContent
    console.log(val) //先確認是否有抓到
    //驗證輸入的合法性
    if (val === '' || isNaN(val)) {
        showHint("請輸入合法數字")
        guessInput.value = ''
        return
    }
    //輸入的是不重複的4個數字
    //new Set(val).length >4 如果去除重複的數字，還是大於4個數字
    if (val.length > 4 || new Set(val).size !== 4) {
        showHint("請確認輸入數字的數量!")
        guessInput.value = ''
        return
    }
    //a,b
    let a = 0, b = 0;
    for (let i = 0; i < answer.length; i++) {
        console.log(answer.length)
        if (val[i] === answer[i]) {
            a++;
        } else if (answer.includes(val[i])) {
            b++;
        }
    }
    if (a === 4) {
        //過關
        //alert("過關!");  換成modal
        modalBootstrap.show()
    }
    guessInput.value = ''//按猜後清空
    appendHistory(a, b, val)
})

function appendHistory(a, b, input) {
    //觀察結構，抓ul、用append方法把li append上去
    //另要注意顏色
    //1.創造元素
    const li = document.createElement("li")
    //2.這個li的classList要有什麼屬性(加class上去)
    li.classList.add("list-group-item")
    //3.還需要span跟文字內容，先把badge做出來
    const span = document.createElement("span")
    const badgeColor = a === 4 ? "bg-success" : "bg-danger"
    //顏色會因為A、B數量而定▲ 類似if
    span.classList.add("badge", badgeColor)
    span.textContent = `${a}A${b}B`
    //在li身上安裝span
    li.append(span, input) //node是??
    guessHistoryList.append(li)
    document.querySelector("li")
    document.getElementsByTagName("li")

}

function showHint(msg) {
    //Toast怎麼打開寫在這裡
    //叫bootstrap把Toast彈出來
    //1.先把dom抓出來(show字的地方)
    gameMsgToast.querySelector(".toast-body").textContent = msg
    //做出bootstrap的執行個體
    //(靜態方法)方法1.呼叫bootstrap.Toast.getOrCreateInstance(代入dom)
    //const toastBootstrap = bootstrap.Toast.getOrCreateInstance(gameMsgToast)
    //接著找到那個執行個體，叫他show
    toastBootstrap.show()
    //怎麼開model或toast??
}

endGameBtn.addEventListener("click",()=>{
    modalBootstrap.hide();
})

//為什麼我沒有下拉式選單