// wwwroot/js/login.js
const input = document.getElementById("Password");
const toggle = document.getElementById("togglePassword");

toggle.addEventListener("click", () => {
    const hidden = input.type === "password";
    input.type = hidden ? "text" : "password";
    toggle.textContent = hidden ? "Masquer" : "Afficher";
});