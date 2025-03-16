document.getElementById("language-toggle").addEventListener("click", function (event) {
    event.preventDefault(); // جلوگیری از تغییر صفحه

    const currentLang = document.documentElement.lang;
    const newLang = currentLang === "fa" ? "en" : "fa";

    // تغییر زبان صفحه
    document.documentElement.lang = newLang;

    // تغییر کلاس‌ها برای زبان
    if (newLang === "en") {
        document.documentElement.classList.add("lang-en");
        document.documentElement.classList.remove("lang-fa");
    } else {
        document.documentElement.classList.add("lang-fa");
        document.documentElement.classList.remove("lang-en");
    }

    // ذخیره زبان جدید در localStorage
    localStorage.setItem("lang", newLang);
});

// بررسی زبان ذخیره‌شده هنگام بارگذاری صفحه
document.addEventListener("DOMContentLoaded", function () {
    const savedLang = localStorage.getItem("lang") || "fa"; // پیش‌فرض فارسی
    document.documentElement.lang = savedLang;

    // تغییر کلاس‌های زبان
    if (savedLang === "en") {
        document.documentElement.classList.add("lang-en");
        document.documentElement.classList.remove("lang-fa");
    } else {
        document.documentElement.classList.add("lang-fa");
        document.documentElement.classList.remove("lang-en");
    }
});
