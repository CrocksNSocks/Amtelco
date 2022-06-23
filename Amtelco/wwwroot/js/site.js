// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*view menu*/

const add = document.getElementById("addAppt"); // collects add button
const edit = document.getElementById("edit"); // collects edit button
const del = document.getElementById("delete"); // collects delete button
const logout = document.getElementById("logout"); // collects logout button

const addAppt = document.getElementById("addAppt");

const viewList = document.getElementById("list"); // List radio button variable
const viewCal = document.getElementById("calender"); // calender radio button variable

addAppt.style.display = "none";
viewCal.style.display = "none";

function viewAddAppt()
{
    addAppt.style.display = "block";
}

function addAppointment()
{
    var createAppt = document.getElementById("list");

    var createRow = createAppt.insertRow(-1);
    var start = createRow.insertCell(0);
    var end = createRow.insertCell(1);
    var name = createRow.insertCell(2);
    var desc = createRow.insertCell(3);
    start.innerHTML = document.getElementById("startAppt").value;
    end.innerHTML = document.getElementById("endAppt").value;
    name.innerHTML = document.getElementById("nameAppt").value;
    desc.innerHTML = document.getElementById("descAppt").value;

    addAppt.style.display = "none";

    return false;
}

function editAppointment() {
    var createAppt = document.getElementById("list");

    var createRow = createAppt.insertRow(-1);
    var start = createRow.insertCell(0);
    var end = createRow.insertCell(1);
    var name = createRow.insertCell(2);
    var desc = createRow.insertCell(3);
    start.innerHTML = document.getElementById("startAppt").value;
    end.innerHTML = document.getElementById("endAppt").value;
    name.innerHTML = document.getElementById("nameAppt").value;
    desc.innerHTML = document.getElementById("descAppt").value;

    addAppt.style.display = "none";

    return false;
}

function deleteAppointment() {
    var createAppt = document.getElementById("list");

    var createRow = createAppt.insertRow(-1);
    var start = createRow.insertCell(0);
    var end = createRow.insertCell(1);
    var name = createRow.insertCell(2);
    var desc = createRow.insertCell(3);
    start.innerHTML = document.getElementById("startAppt").value;
    end.innerHTML = document.getElementById("endAppt").value;
    name.innerHTML = document.getElementById("nameAppt").value;
    desc.innerHTML = document.getElementById("descAppt").value;

    addAppt.style.display = "none";

    return false;
}

function logout() {
    var createAppt = document.getElementById("list");

    var createRow = createAppt.insertRow(-1);
    var start = createRow.insertCell(0);
    var end = createRow.insertCell(1);
    var name = createRow.insertCell(2);
    var desc = createRow.insertCell(3);
    start.innerHTML = document.getElementById("startAppt").value;
    end.innerHTML = document.getElementById("endAppt").value;
    name.innerHTML = document.getElementById("nameAppt").value;
    desc.innerHTML = document.getElementById("descAppt").value;

    addAppt.style.display = "none";

    return false;
}
/*view menu*/


function SelectCal() {
    viewList.style.display = "none";
    viewCal.style.display = "block";
}

function SelectList() {
    viewList.style.display = "block";
    viewCal.style.display = "none";
}

