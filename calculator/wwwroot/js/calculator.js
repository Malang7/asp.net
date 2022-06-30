// declare som variables, it have to be global 

let number; 
let operator = ""; 
let all  = "";  
let array  = [];  


$(document).ready(function() // main function to get ready the document 
    {
        
        // this function display the numbers into the label  
        $(".number").click(function (e)
        {
            // target get the DOM object:  if they are div, button etc
            // value: get the value 
            // i dont understand what e do here 

            number  = e.target.value;
                                       
            if(operator != "")
            {
                all +=operator;                 // adding the opreator to the label  
                operator = "";  
            }
            
            all += number; // to have a 100 and more  numbers  
            
            $(".screen")[0].value =  all; // update the entry  
           // why we do need to use [0] // what is the point of that? 
            
        })

        $(".operator").click(function (e)
        {
            operator = e.target.value; // getting the value  
            $(".screen")[0].value = all + operator;   // updating the entry  
        })
        
       

    }
)