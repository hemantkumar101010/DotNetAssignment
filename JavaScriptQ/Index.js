//var , let and const 
//var is a globle keyword to declare variable
var name = "Hemant";
console.log(name);

//const keyword is used when we do not want to change the variable in the program
const companyName = "Kellton";
console.log(companyName);

//let: is a block level keyword to defind variable 
{
    let name = "Rahul";
    console.log(name);
}
name = "Ram";
console.log(name);


// ===(operator compare value of operand as well as thier type) vs ==(only compare values) 

var marks =80;
if(marks==="80")
{
  console.log("value and type are same");
}
else if(marks==80){
    console.log("value is same but type is different");
}

