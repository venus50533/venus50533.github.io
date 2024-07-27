const { createApp } = Vue;

createApp({
  data: function () {
    return {
      selected: {
        modal:"",
        name: "",
        basePrice: "",
        color: "",
        url: [],
        capacity: "",
        price: "",
      },
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
            ],
          },
          {
            name: "藍色鈦金屬",
            imgurl: [
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV1.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV2.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-bluetitanium_AV3.webp",
            ],
          },
          {
            name: "白色鈦金屬",
            imgurl: [
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV1.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV2.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-whitetitanium_AV3.webp",
            ],
          },
          {
            name: "黑色鈦金屬",
            imgurl: [
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV1.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV2.webp",
              "./img/pro/iphone-15-pro-finish-select-202309-6-1inch-blacktitanium_AV3.webp",
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
            ],
          },
          {
            name: "藍色鈦金屬",
            imgurl: [
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV1.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV2.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-bluetitanium_AV3.webp",
            ],
          },
          {
            name: "白色鈦金屬",
            imgurl: [
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV1.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV2.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-whitetitanium_AV3.webp",
            ],
          },
          {
            name: "黑色鈦金屬",
            imgurl: [
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV1.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV2.webp",
              "./img/proMax/iphone-15-pro-finish-select-202309-6-7inch-blacktitanium_AV3.webp",
            ],
          },
        ],
        proCapacity: [
          { size: "128", price: "NT$36,900" },
          { size: "256", price: "NT$40,400" },
          { size: "512", price: "NT$47,400" },
          { size: "1TB", price: "NT$54,400" },
        ],
        maxCapacity: [
          { size: "256", price: "NT$44,900" },
          { size: "512", price: "NT$51,900" },
          { size: "1TB", price: "NT$58,900" },
        ],
      },
    };
  },
  watch: {
    selected: {
      handler() {
        console.log(this.selected);
      },
      deep: true,
      immediate: true,
    },
  },
  methods: {
    hey() {},
  },
}).mount("#app");
