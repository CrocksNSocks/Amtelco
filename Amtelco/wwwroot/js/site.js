
/*****TOOL BAR FOR APPOINTMENT PAGE*****/
/* This will only bring the required UI for adding, editing and Deleting appointments */

const add = document.getElementById("addAppt"); // collects add button
const edit = document.getElementById("edit"); // collects edit button
const del = document.getElementById("delete"); // collects delete button
const logout = document.getElementById("logout"); // collects logout button

/*****FORM FOR ADDING APPOINTMENT*****/
const addAppt = document.getElementById("addAppt"); // Makes the Create Appointment Form elements for add Appointment
const chooseAppt = document.getElementById("chooseAppt");//  variables for easier code management
const editAppt = document.getElementById("editAppt");
const deleteAppt = document.getElementById("deleteAppt");


addAppt.style.display = "none"; // Sets the Appointment forms invisible by default
chooseAppt.style.display = "none";
editAppt.style.display = "none";
deleteAppt.style.display = "none";

// var WebAPI = new ToDoItemsController; // CREATES AN INSTANCE OF THE API CONTROLLER
// 

function viewAddAppt() // Create appt should only be active, allows the user to switch between multiple
{                      // options without having multiple forms open at once
    
    addAppt.style.display = "block";
    chooseAppt.style.display = "none";
    editAppt.style.display = "none";
    deleteAppt.style.display = "none";
}


function addAppointment() // Creates an Appointment from a form and pushes it to the Web API controller
{                         // List View and Calender View will both have Appointment Information
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
    // TODO: Push the Changes made to this list on the
    // Web API and to the Interative Calender

    /*
     * WebAPI.createItem(startAppt, endAppt, nameAppt, descAppt); // creates new Appointment and saves it
     */
}

function viewEditAppt() // Makes The Choose appointment Visible
{                       // After an appointment is chosen 
    chooseAppt.style.display = "block";
    editAppt.style.display = "none";
    addAppt.style.display = "none";
    deleteAppt.style.display = "none";
}

function chooseAppointment() {
    var chooseAppt = document.getElementById("edit");         // This collects the Table Row where the future rows will go

    // var repStart = document.getElementById("newStart").value; //  This collects the Button that will prompt the user to pick a row to change Appointment info

    chooseAppt.style.display = "none";
    editAppt.style.display = "block";
    
}

function editAppointment() {
    var editAppt = document.getElementById("list");
    /*
    * var item = new TodoItem;
    * 
    * var newItem.Id = WebAPI.GetItem(item.Id).Id; // collects the proper ID from the Web API
    * 
    * newItem.Start = editAppt.value; // Todo Item obtains appointment info from HTML form
    * newItem.End = editAppt.value;
    * newItem.Name = editAppt.value;
    * newItem.Desc = editAppt.value;
    * 
    * 
    * WebAPI.UpdateItem(newItem.ID); // updates the info from the webAPI
    * 
    */
    editAppt.style.display = "none"; // after submitting the form the edit elements disappear

    return false;
}

function viewDelAppt() {
    deleteAppt.style.display = "block"; // Delete appointment should be the only element visible
    chooseAppt.style.display = "none";  // other elements are turned invisble
    editAppt.style.display = "none";
    addAppt.style.display = "none";
}

function deleteAppointment() {
    var delAppt = document.getElementById("list"); // gets the value of the appointment list in the UI
    var delRow = document.getElementById("newStart").value; //  This collects the Button that will prompt the user to pick a row to change Appointment info
    /*
    * var item = new TodoItem;
    * 
    * var delItem.Id = WebAPI.GetItem(item.Id).Id; // sets the item to be deleted to be the correct ID
    * 
    * WebAPI.DeleteItem(delItem); // updates the info from the webAPI
    * 
    */
    deleteAppt.style.display = "none";

    return false;
}

/*****MENU FOR SELECTING LIST OR CALENDER MODE*****/
const viewList = document.getElementById("list"); // List radio button variable
const viewCal = document.getElementById("calender"); // calender radio button variable

viewCal.style.display = "none"; // List is visible by default

function SelectCal() {
    viewList.style.display = "none"; // Makes the List invisible and Makes the Calender Appear
    viewCal.style.display = "block";
}

function SelectList() {
    viewList.style.display = "block"; // Makes the Calender invisible and Makes the List Appear
    viewCal.style.display = "none";
}

/*****LOG IN CREDENTIALS*****/

const uname = document.getElementById("uname").value; // creates instance of username input from login from
const pword = document.getElementById("pword").value; // creates instance of password input from login from

function verify() {
    /* var creditID[] = jsongconfig("Login Credintials"); // creates instance of JSON
     * for (int i = 0; i < creditID.length(); i++) { // iterates through ID of usernames and passwords
     *     if(uname == credit[i].username){ // compares input for JSON array
     *         if(if pword == credit[i].password){ // compares inpur for JSON array
     *          // Log user in
     *         }
     *         else{
     *             // alert message "Invalid Password";
     *             // create token with user;
     *             //return token;
     *         }
     *     }
     *     else{
     *         // Invalid Username
     *     }
     * }
     * 
     * 
     * 
     */

    function logout() {
        // obtain token
        // Delete token
        // send the user back to the homepage;
    }
}
