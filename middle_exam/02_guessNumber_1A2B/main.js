// 20240719 下午
// https://tw.search.yahoo.com/search?fr=mcafee&type=E210TW885G0&p=sweetalert2
const startBtn = document.querySelector("#start_btn")
const showAnsBtn = document.querySelector("#show_answer_btn")
const restartBtn = document.querySelector("#restart_btn")
const guessHistoryList = document.querySelector("#guess_history_list")
let answer;
const guessInput = document.querySelector("#guess_input")
const guessBtn = document.querySelector("#guess_btn")
const gameMsgToast = document.querySelector("#game_msg_toast")
//建立bootstrap執行個體(可建可不建)
const toastBootstrap = new bootstrap.Toast(gameMsgToast, {
    delay: 1000,//1秒
    // autohide: false,
    Animation: false
})
const modalBootstrap = new bootstrap.Modal(document.querySelector("#end_game_modal"));
gameMsgToast.addEventListener("hide.bs.toast", () => {
    console.log("toast hide!")
}
)
const endGameBtn = document.querySelector("#end_game_btn");
endGameBtn.addEventListener("click",()=>{
    modalBootstrap.hide()
    initGame()
})

function initGame() {
    //產出answer
    answer = generateAns()
    //清空紀錄
    guessHistoryList.innerHTML = ""
}
function generateAns() {
    const numArr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    numArr.sort((a, b) => getRandomArbitrary(-1, 1)) //a.b可以忽略
    return numArr.slice(0, 4).join("") //從頭開始取4個

}
function getRandomArbitrary(min, max) {
    return Math.random() * (max - min) + min;
}

startBtn.addEventListener("click", initGame);
restartBtn.addEventListener("click", initGame);
showAnsBtn.addEventListener("click", () => {
   if(answer){
       showHint(`answer:${answer}`)
   }else{
    showHint("請先按下開始唷~")
   }
})

guessBtn.addEventListener("click", () => {
    const val = guessInput.value.trim()
    //驗證輸入的合法性
    if (val === "" || isNaN(val)) {
        alert("請輸入合法的數字!")
        guessInput.value = ""
        return
    }
    guessInput.value = ""  //最後清空輸入框
    //輸入的是不重複的4個數字
    //set可以去除重複
    if (val.length > 4 || new Set(val).size !== 4) {
        showHint("請確認輸入數字的數量!")
        guessInput.value = ""
        return
    }
    //a,b
    let a = 0, b = 0
    for (let i = 0; i < answer.length; i++) {
        if (val[i] === answer[i]) {
            a++
        }
        else if (answer.includes(val[i])) {
            b++
        }

    }

    if (a === 4) {
        //過關
        modalBootstrap.show()
    }
    guessInput.value = ""
    appendHistory(a, b, val)
})


function appendHistory(a, b, input) {
    const li = document.createElement("li")
    li.classList.add("list-group-item")
    const span = document.createElement("span")
    const badgeColor = a === 4 ? "bg-success" : "bg-danger"
    span.classList.add("badge",badgeColor)
    span.textContent =`${a}A${b}B`
    li.append(span,input)
    guessHistoryList.append(li)
}

function showHint(msg) {
    gameMsgToast.querySelector(".toast-body").textContent = msg
    //bootstrap第二種用法(時間3:00:00)
    //1.建立b執行個體  const toastBootstrap = bootstrap.Toast.getOrCreateInstance(gameMsgToast)
    //2.使用執行個體方法 .show()
    toastBootstrap.show()
}

//看一下[...]  轉陣列??
//set 可以看一下