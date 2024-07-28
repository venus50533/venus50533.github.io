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
    classic15: {
      name: "iPhone 15",
      basePrice: "NT$29,900",
    },
    plus15: {
      name: "iPhone 15 Plus",
      basePrice: "NT$32,900",
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

    classicColors: [
      {
        name: "藍色",
        imgurl: [
          "./img/classic/iphone-15-finish-select-202309-6-1inch-blue.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-blue_AV1.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-blue_AV2.webp",
          "./img/classic/iphone-15-blue-select-202309_AV2.jpg",
        ],
      },
      {
        name: "粉紅色",
        imgurl: [
          "./img/classic/iphone-15-finish-select-202309-6-1inch-pink.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-pink_AV1.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-pink_AV2.webp",
          "./img/classic/iphone-15-pink-select-202309_AV2.jpg",
        ],
      },
      {
        name: "黃色",
        imgurl: [
          "./img/classic/iphone-15-finish-select-202309-6-1inch-yellow.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-yellow_AV1.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-yellow_AV2.webp",
          "./img/classic/iphone-15-yellow-select-202309_AV2.jpg",
        ],
      },
      {
        name: "綠色",
        imgurl: [
          "./img/classic/iphone-15-finish-select-202309-6-1inch-green.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-green_AV1.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-green_AV2.webp",
          "./img/classic/iphone-15-green-select-202309_AV2.jpg",
        ],
      },

      {
        name: "黑色",
        imgurl: [
          "./img/classic/iphone-15-finish-select-202309-6-1inch-black.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-black_AV1.webp",
          "./img/classic/iphone-15-finish-select-202309-6-1inch-black_AV2.webp",
          "./img/classic/iphone-15-black-select-202309_AV2.jpg",
        ],
      },
    ],
    plusColors: [
      {
        name: "藍色",
        imgurl: [
          "./img/plus/iphone-15-finish-select-202309-6-7inch-blue.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-blue_AV1.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-blue_AV2.webp",
          "./img/plus/iphone-15-plus-blue-select-202309_AV2.jpg",
        ],
      },
      {
        name: "粉紅色",
        imgurl: [
          "./img/plus/iphone-15-finish-select-202309-6-7inch-pink.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-pink_AV1.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-pink_AV2.webp",
          "./img/plus/iphone-15-plus-pink-select-202309_AV2.jpg",
        ],
      },
      {
        name: "黃色",
        imgurl: [
          "./img/plus/iphone-15-finish-select-202309-6-7inch-yellow.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-yellow_AV1.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-yellow_AV2.webp",
          "./img/plus/iphone-15-plus-yellow-select-202309_AV2.jpg",
        ],
      },
      {
        name: "綠色",
        imgurl: [
          "./img/plus/iphone-15-finish-select-202309-6-7inch-green.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-green_AV1.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-green_AV2.webp",
          "./img/plus/iphone-15-plus-green-select-202309_AV2.jpg",
        ],
      },
      {
        name: "黑色",
        imgurl: [
          "./img/plus/iphone-15-finish-select-202309-6-7inch-black.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-black_AV1.webp",
          "./img/plus/iphone-15-finish-select-202309-6-7inch-black_AV2.webp",
          "./img/plus/iphone-15-plus-black-select-202309_AV2.jpg",
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
    classicCapacity: [
      { size: "128GB", price: "NT$29,900" },
      { size: "256GB", price: "NT$33,400" },
      { size: "512GB", price: "NT$40,400" },
    ],
    plusCapacity: [
      { size: "128GB", price: "NT$32,900" },
      { size: "256GB", price: "NT$36,400" },
      { size: "512GB", price: "NT$43,400" },
    ],
    proColorToken: [
      "./img/iphone-pro-finish-naturaltitanium-202309.jpg",
      "./img/iphone-pro-finish-bluetitanium-202309.jpg",
      "./img/iphone-pro-finish-whitetitanium-202309.jpg",
      "./img/iphone-pro-finish-blacktitanium-202309.jpg",
    ],
    classicColorToken: [
      "./img/15color/finish-blue-202309.jpg",
      "./img/15color/finish-pink-202309.jpg",
      "./img/15color/finish-yellow-202309.jpg",
      "./img/15color/finish-green-202309.jpg",
      "./img/15color/finish-black-202309.jpg",
    ],
  },
};
// 點了modal左上角的價格要改變(基礎價格)
//我要有一個空變數承接目前選擇項目
const proName = "iPhone 15 Pro";
const maxName = "iPhone 15 Pro Max";
const classicName = "iPhone 15";
const plusName = "iPhone 15 Plus";

const proBtn = document.querySelector("#modalPro");
const maxBtn = document.querySelector("#modalMax");
let titlePrice = document.querySelector("#title_price"); //title span內容
let bannerPrice = document.querySelector("#banner_price"); //banner span內容
let selectedName = "";
let selectedPrice = "NT$36,900";
let selectedColor = "";
let selectedSize = "";
let selectedPage = "";

const btn128 = document.querySelector("#size_s_btn");
const btn256 = document.querySelector("#size_m_btn");
const btn512 = document.querySelector("#size_l_btn");
const btn1Tb = document.querySelector("#size_xl_btn");
const btn128Price = document.querySelector("#size_s_btn_price");
const btn256Price = document.querySelector("#size_m_btn_price");
const btn512Price = document.querySelector("#size_l_btn_price");
const btn1TbPrice = document.querySelector("#size_xl_btn_price");
const classicPage = document.querySelector("#classic_page");
const proPage = document.querySelector("#pro_page");
const pageSlogn = document.querySelector("#page_slogn");
const banBlock = document.querySelector("#banner_block");
// 照片要與顏色連動
// 機型>按鈕的資料也都要換 機型、價格
// 顏色> 藍色 粉紅色  黃色  綠色  黑色
// 儲存裝置 > 128GB 256GB 512GB

// banner 標題(左)
// banner 機型、容量、顏色、價格
// 右邊(外觀、顏色、儲存裝置)都點了，下方的banner才會出現 尚未搞定

// function bannerDisplay(){
//   if (selectedName && selectedColor && selectedSize) {
//         banBlock.classList.remove("d-none");
//         banBlock.classList.add("d-block");
//       } else {
//         banBlock.classList.add("d-none");
//         banBlock.classList.remove("d-block");
//       }
// }
window.addEventListener("load", () => {
  proCarousel.classList.remove("d-none");
  pBtn.classList.add("d-none");
  changeColorSelector();
  bannerDisplay();
});

classicPage.addEventListener("click", (e) => {
  changeTitle(e.target.getAttribute("value"));
  pagesDecided();
  changeColorSelector();
  btn1Tb.classList.add("d-none");
  classicCarousel.classList.remove("d-none");
  proCarousel.classList.add("d-none");
  bImg.src = "./img/classic/iphone-15-blue-select-202309_AV2.jpg";
  selectedColor = " ";
});
proPage.addEventListener("click", (e) => {
  changeTitle(e.target.getAttribute("value"));
  pagesDecided();
  changeColorSelector();
  btn1Tb.classList.remove("d-none");
  proCarousel.classList.remove("d-none");
  classicCarousel.classList.add("d-none");
});
//改掉按鈕的innerHtml 跟 value 跟 price

//決定現在是什麼頁面
function pagesDecided() {
  if (selectedName === proName || selectedName === maxName) {
    selectedPage = proName;
  } else if (selectedName === classicName || selectedName === plusName) {
    selectedPage = classicName;
  }
  return selectedPage;
}

proBtn.addEventListener("click", (e) => {
  changeTitle(e.currentTarget.value);
  console.log(e.currentTarget.value);

  if (selectedName === proName || selectedName === maxName) {
    btn128.classList.remove("d-none");
  }
  changeCapacitybtnPrice();
});
maxBtn.addEventListener("click", (e) => {
  console.log(e.currentTarget.value);

  changeTitle(e.currentTarget.value);
  if (selectedPage === proName || selectedName === maxName) {
    btn128.classList.add("d-none");
  }
  changeCapacitybtnPrice();
});

function changeCapacitybtnPrice() {
  if (selectedName === proName) {
    btn128Price.textContent = data.info.proCapacity.find(
      (x) => x.size === "128GB"
    ).price;
    btn256Price.textContent = data.info.proCapacity.find(
      (x) => x.size === "256GB"
    ).price;
    btn512Price.textContent = data.info.proCapacity.find(
      (x) => x.size === "512GB"
    ).price;
    btn1TbPrice.textContent = data.info.proCapacity.find(
      (x) => x.size === "1TB"
    ).price;
  } else if (selectedName === maxName) {
    btn256Price.textContent = data.info.maxCapacity.find(
      (x) => x.size === "256GB"
    ).price;
    btn512Price.textContent = data.info.maxCapacity.find(
      (x) => x.size === "512GB"
    ).price;
    btn1TbPrice.textContent = data.info.maxCapacity.find(
      (x) => x.size === "1TB"
    ).price;
  } else if (selectedName === classicName) {
    btn128Price.textContent = data.info.classicCapacity.find(
      (x) => x.size === "128GB"
    ).price;
    btn256Price.textContent = data.info.classicCapacity.find(
      (x) => x.size === "256GB"
    ).price;
    btn512Price.textContent = data.info.classicCapacity.find(
      (x) => x.size === "512GB"
    ).price;
  } else if (selectedName === plusName) {
    btn128Price.textContent = data.info.plusCapacity.find(
      (x) => x.size === "128GB"
    ).price;
    btn256Price.textContent = data.info.plusCapacity.find(
      (x) => x.size === "256GB"
    ).price;
    btn512Price.textContent = data.info.plusCapacity.find(
      (x) => x.size === "512GB"
    ).price;
  }
}

btn128.addEventListener("click", (e) => getSizeAndprice(e));
btn256.addEventListener("click", (e) => getSizeAndprice(e));
btn512.addEventListener("click", (e) => getSizeAndprice(e));
btn1Tb.addEventListener("click", (e) => getSizeAndprice(e));

function changeTitle(modalBtnEvent) {
  //取得modal資料
  //改變span內容
  selectedName = modalBtnEvent;
  console.log(selectedName);
  if (selectedName === proName) {
    selectedPrice = data.info.pro.basePrice;
  } else if (selectedName === maxName) {
    selectedPrice = data.info.proMax.basePrice;
  } else if (selectedName === classicName) {
    selectedPrice = data.info.classic15.basePrice;
  } else if (selectedName === plusName) {
    selectedPrice = data.info.plus15.basePrice;
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
  } else if (selectedName === maxName) {
    selectedPrice = data.info.maxCapacity.find(
      (x) => x.size === selectedSize
    ).price;
  } else if (selectedName === classicName) {
    selectedPrice = data.info.classicCapacity.find(
      (x) => x.size === selectedSize
    ).price;
  } else if (selectedName === plusName) {
    selectedPrice = data.info.plusCapacity.find(
      (x) => x.size === selectedSize
    ).price;
  }
  changeTextContent();
}
const appearanceName = document.querySelector("#color_name");
const bannerName = document.querySelector("#banner_name");
const bannerInfo = document.querySelector("#banner_info");
const modalBtnNameA = document.querySelector("#modal_btn_name_a");
const modalBtnNameB = document.querySelector("#modal_btn_name_b");
const modalBtnNamePriceA = document.querySelector("#modal_btn_name_price_a");
const modalBtnNamePriceB = document.querySelector("#modal_btn_name_price_b");

//   2.更改(中)modal+儲存裝置+顏色，(中下)與尺寸綁定的價格
function changeTextContent() {
  if (selectedName === proName || selectedName === maxName) {
    pageSlogn.textContent = proName;
    //改變按鈕的名字 value
    modalBtnNameA.innerHTML = `${proName}<br><small>6.1吋顯示器'</small>`;
    modalBtnNameB.innerHTML = `${maxName}<br><small>6.7吋顯示器'</small>`;
    modalBtnNamePriceA.innerHTML = `${data.info.pro.basePrice}起`;
    modalBtnNamePriceB.innerHTML = `${data.info.proMax.basePrice}起`;
    proBtn.value = proName;
    maxBtn.value = maxName;
  } else if (selectedName === classicName || selectedName === plusName) {
    pageSlogn.textContent = classicName;
    //改變按鈕的名字 value
    modalBtnNameA.innerHTML = `${classicName}<br><small>6.1吋顯示器'</small>`;
    modalBtnNameB.innerHTML = `${plusName}<br><small>6.7吋顯示器'</small>`;
    modalBtnNamePriceA.innerHTML = `${data.info.classic15.basePrice}起`;
    modalBtnNamePriceB.innerHTML = `${data.info.plus15.basePrice}起`;
    proBtn.value = classicName;
    maxBtn.value = plusName;
  }
  titlePrice.textContent = selectedPrice;
  appearanceName.textContent = selectedColor;
  bannerPrice.textContent = selectedPrice;
  bannerName.textContent = selectedName;
  if (selectedPrice && selectedName && selectedColor) {
    bannerInfo.textContent = `${selectedName}   ${selectedSize}   ${selectedColor}`;
  }
}

// 點了顏色要改變左邊的圖片組,並更改modal(左)，及其照片
const nBtn = document.querySelector("#n_btn");
const bBtn = document.querySelector("#b_btn");
const wBtn = document.querySelector("#w_btn");
const bkBtn = document.querySelector("#bk_btn");
const pBtn = document.querySelector("#p_btn");
const cImgM = document.querySelector("#c_img_main");
const cImgS = document.querySelector("#c_img_second");
const cImgT = document.querySelector("#c_img_third");
const cImgF = document.querySelector("#c_img_fourth");

const cImgMB = document.querySelector("#c_img_main_b");
const cImgSB = document.querySelector("#c_img_second_b");
const cImgTB = document.querySelector("#c_img_third_b");

const bImg = document.querySelector("#b_img");
const colorTokenA = document.querySelector("#color_token_a");
const colorTokenB = document.querySelector("#color_token_b");
const colorTokenC = document.querySelector("#color_token_c");
const colorTokenD = document.querySelector("#color_token_d");
const colorTokenE = document.querySelector("#color_token_e");

const proCarousel = document.querySelector("#pro_carousel");
const classicCarousel = document.querySelector("#classic_carousel");

nBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
  console.log(e.currentTarget.value);
});
bBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
  console.log(e.currentTarget.value);
});
wBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
  console.log(e.currentTarget.value);
});
bkBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
  console.log(e.currentTarget.value);
});

pBtn.addEventListener("click", (e) => {
  changeColorPic(e);
  changeTextContent();
  console.log(e.currentTarget.value);
});

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
  } else if (selectedName === classicName) {
    selectedColImgAry = data.info.classicColors.find(
      (x) => x.name === selectedColor
    );
  } else if (selectedName === plusName) {
    selectedColImgAry = data.info.plusColors.find(
      (x) => x.name === selectedColor
    );
  }
  if (selectedName === proName || selectedName === maxName) {
    cImgM.src = selectedColImgAry.imgurl[0];
    cImgS.src = selectedColImgAry.imgurl[1];
    cImgT.src = selectedColImgAry.imgurl[2];
    cImgF.src = selectedColImgAry.imgurl[3];
    bImg.src = selectedColImgAry.imgurl[4];
  } else if (selectedName === classicName || selectedName === plusName) {
    cImgMB.src = selectedColImgAry.imgurl[0];
    cImgSB.src = selectedColImgAry.imgurl[1];
    cImgTB.src = selectedColImgAry.imgurl[2];
    bImg.src = selectedColImgAry.imgurl[3];
  }
}

function changeColorSelector() {
  if (selectedName === classicName || selectedName === plusName) {
    pBtn.classList.remove("d-none");
    nBtn.value = "藍色";
    bBtn.value = "粉紅色";
    wBtn.value = "黃色";
    bkBtn.value = "綠色";
    pBtn.value = "黑色";
    colorTokenA.src = data.info.classicColorToken[0];
    colorTokenB.src = data.info.classicColorToken[1];
    colorTokenC.src = data.info.classicColorToken[2];
    colorTokenD.src = data.info.classicColorToken[3];
    colorTokenE.src = data.info.classicColorToken[4];
  } else if (selectedName === proName || selectedName === maxName) {
    pBtn.classList.add("d-none");
    nBtn.value = "原色鈦金屬";
    bBtn.value = "藍色鈦金屬";
    wBtn.value = "白色鈦金屬";
    bkBtn.value = "黑色鈦金屬";
    colorTokenA.src = data.info.proColorToken[0];
    colorTokenB.src = data.info.proColorToken[1];
    colorTokenC.src = data.info.proColorToken[2];
    colorTokenD.src = data.info.proColorToken[3];
  }
}
