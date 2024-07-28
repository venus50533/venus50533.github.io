const data = {
  info: {
    pro: {
      name: "iPhone 15 Pro",
      basePrice: "NT$36,900",
    },
    proMax: {
      name: "iPhone 15 ProMax",
      basePrice: "NT$44,900",
    },
    proColors: [
      {
        name: "原色鈦金屬",
        imgurl: [
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-naturaltitanium.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-naturaltitanium_AV1.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-naturaltitanium_AV2.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-naturaltitanium_AV3.webp",
          "./img/pro/iphone-15-pro-naturaltitanium-select_AV2.jpg",
        ],
      },
      {
        name: "藍色鈦金屬",
        imgurl: [
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV1.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV2.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV3.webp",
          "./img/pro/iphone-15-pro-bluetitanium-select_AV2.jpg",
        ],
      },
      {
        name: "白色鈦金屬",
        imgurl: [
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV1.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV2.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV3.webp",
          "./img/pro/iphone-15-pro-whitetitanium-select_AV2.jpg",
        ],
      },
      {
        name: "黑色鈦金屬",
        imgurl: [
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV1.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV2.webp",
          "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV3.webp",
          "./img/pro/iphone-15-pro-blacktitanium-select_AV2.jpg",
        ],
      },
    ],
    maxColors: [
      {
        name: "原色鈦金屬",
        imgurl: [
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-naturaltitanium.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-naturaltitanium_AV1.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-naturaltitanium_AV2.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-naturaltitanium_AV3.webp",
          "./img/proMax/iphone-15-pro-max-naturaltitanium-select_AV2.jpg",
        ],
      },
      {
        name: "藍色鈦金屬",
        imgurl: [
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV1.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV2.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV3.webp",
          "./img/proMax/iphone-15-pro-max-bluetitanium-select_AV2.jpg",
        ],
      },
      {
        name: "白色鈦金屬",
        imgurl: [
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV1.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV2.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV3.webp",
          "./img/proMax/iphone-15-pro-max-whitetitanium-select_AV2.jpg",
        ],
      },
      {
        name: "黑色鈦金屬",
        imgurl: [
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV1.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV2.webp",
          "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV3.webp",
          "./img/proMax/iphone-15-pro-max-blacktitanium-select_AV2.jpg",
        ],
      },
    ],
    proCapacity: [
      { size: "128GB", price: "NT$36,900" },
      { size: "256GB", price: "NT$40,400" },
      { size: "512GB", price: "NT$47,400" },
      { size: "1TB", price: "NT$54,400" },
    ],
    maxCapacity: [
      { size: "256GB", price: "NT$44,900" },
      { size: "512GB", price: "NT$51,900" },
      { size: "1TB", price: "NT$58,900" },
    ],
  },
};
// 點了modal左上角的價格要改變(基礎價格)
//我要有一個空變數承接目前選擇項目
const proName = "iPhone 15 Pro";
const maxName = "iPhone 15 ProMax";
const proBtn = document.querySelector("#modalPro");
const maxBtn = document.querySelector("#modalMax");
let titlePrice = document.querySelector("#title_price"); //title span內容
let bannerPrice = document.querySelector("#banner_price"); //banner span內容
let selectedName = "iPhone 15 Pro";
let selectedPrice = "NT$36,900";
let selectedColor = "";
let selectedSize = "";

const btn128 = document.querySelector("#size_s_btn");
const btn256 = document.querySelector("#size_m_btn");
const btn512 = document.querySelector("#size_l_btn");
const btn1Tb = document.querySelector("#size_xl_btn");
const btn128Price = document.querySelector("#size_s_btn_price");
const btn256Price = document.querySelector("#size_m_btn_price");
const btn512Price = document.querySelector("#size_l_btn_price");
const btn1TbPrice = document.querySelector("#size_xl_btn_price");

proBtn.addEventListener("click", (e) => {
  changeTitle(e);
  btn128.classList.remove("d-none");
  changeCapacitybtnPrice();
});
maxBtn.addEventListener("click", (e) => {
  changeTitle(e);
  btn128.classList.add("d-none");
  changeCapacitybtnPrice();
});

function changeCapacitybtnPrice() {
  if (selectedName === proName) {
    btn128Price.textContent = data.info.proCapacity.find((x)=>x.size==="128GB").price
    btn256Price.textContent = data.info.proCapacity.find((x)=>x.size==="256GB").price
    btn512Price.textContent = data.info.proCapacity.find((x)=>x.size==="512GB").price
    btn1TbPrice.textContent = data.info.proCapacity.find((x)=>x.size==="1TB").price    
    
  } else if (selectedName === maxName) {
    btn256Price.textContent = data.info.maxCapacity.find((x)=>x.size==="256GB").price
    btn512Price.textContent = data.info.maxCapacity.find((x)=>x.size==="512GB").price
    btn1TbPrice.textContent = data.info.maxCapacity.find((x)=>x.size==="1TB").price
    
  }
}

btn128.addEventListener("click", (e) => getSizeAndprice(e));
btn256.addEventListener("click", (e) => getSizeAndprice(e));
btn512.addEventListener("click", (e) => getSizeAndprice(e));
btn1Tb.addEventListener("click", (e) => getSizeAndprice(e));

function changeTitle(modalBtnEvent) {
  //取得modal資料
  //改變span內容
  selectedName = modalBtnEvent.currentTarget.value;
  if (selectedName === proName) {
    selectedPrice = data.info.pro.basePrice;
  } else if (selectedName === maxName) {
    selectedPrice = data.info.proMax.basePrice;
  }
  changeTextContent();
}

// 點了儲存裝置左上角的價格要改變(與尺寸綁定的價格)
function getSizeAndprice(sizeBtnevent) {
  selectedSize = sizeBtnevent.currentTarget.value;
  if (selectedName === proName) {
    selectedPrice = data.info.proCapacity.find(
      (x) => x.size === selectedSize
    ).price;
    console.log(selectedSize)
    
  } else if (selectedName === maxName) {
    selectedPrice = data.info.maxCapacity.find(
      (x) => x.size === selectedSize
    ).price;
  }
  changeTextContent();
}

const bannerName = document.querySelector("#banner_name");
const bannerInfo = document.querySelector("#banner_info");

//   2.更改(中)modal+儲存裝置+顏色，(中下)與尺寸綁定的價格
function changeTextContent() {
  titlePrice.textContent = selectedPrice;
  bannerPrice.textContent = selectedPrice;
  bannerName.textContent = selectedName;
  if(selectedPrice && selectedName && selectedColor){
    bannerInfo.textContent = `${selectedName}   ${selectedSize}   ${selectedColor}`
  }
  console.log(selectedColor)
  
}
changeTextContent()

// 點了顏色要改變左邊的圖片組,並更改modal(左)，及其照片
const nBtn = document.querySelector("#n_btn");
const bBtn = document.querySelector("#b_btn");
const wBtn = document.querySelector("#w_btn");
const bkBtn = document.querySelector("#bk_btn");
const cImgM = document.querySelector("#c_img_main");
const cImgS = document.querySelector("#c_img_second");
const cImgT = document.querySelector("#c_img_third");
const cImgF = document.querySelector("#c_img_fourth");
const bImg = document.querySelector("#b_img");

nBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
});
bBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
});
wBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
});
bkBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
});
//第四層要用到linq尋找
function changeColorPic(colorBtnEvent) {
  selectedColor = colorBtnEvent.currentTarget.value;  
  let selectedColImgAry;
  if (selectedName === proName) {
    selectedColImgAry = data.info.proColors.find(
      (x) => x.name === selectedColor
    );
  } else if (selectedName === maxName) {
    selectedColImgAry = data.info.maxColors.find(
      (x) => x.name === selectedColor
    );
  }
  cImgM.src = selectedColImgAry.imgurl[0];
  cImgS.src = selectedColImgAry.imgurl[1];
  cImgT.src = selectedColImgAry.imgurl[2];
  cImgF.src = selectedColImgAry.imgurl[3];
  bImg.src = selectedColImgAry.imgurl[4];
}


// 右邊(外觀、顏色、儲存裝置)都點了，下方的banner才會出現 尚未搞定
const banBlock = document.querySelector("#banner_block");

// window.addEventListener("load",()=>{
//   if (selectedName && selectedColor && selectedSize) {
//         banBlock.classList.remove("d-none");
//         banBlock.classList.add("d-block");
//       } else {
//         banBlock.classList.add("d-none");
//         banBlock.classList.remove("d-block");
//       }

// })


//要將畫面價錢改掉 可能要空白
