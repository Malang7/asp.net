// declare som variables, it have to be global 

let number; 
let operator = ""; 
let all  = "";  
let claer  = "";  


$(document).ready(function() // main function to get ready the document 
    {
        if ($(".screen")[0].value == isNaN)
        {
            $(".screen")[0].value = "0"
        }
        
        // this function display the numbers into the label  
        $(".number").click(function (e)
        {
            // target get the DOM object:  if they are div, button etc
            // value: get the value
            
            number  = e.target.value;
                                       
            if(operator != "")
            {
                all +=operator;                 // adding the opreator to the label  
                operator = "";  
            }
            
            all += number; // to have a 100 and more  numbers  
            
            $(".screen")[0].value =  all; // update the entry
            
        })

        $(".operator").click(function (e)
        {
            operator = e.target.value; // getting the value  
            $(".screen")[0].value = all + operator;   // updating the entry  
        })
        
        
        $(".equal").click(function ()
        {
            all  = eval(all) // evaluates the expression  
            $(".screen")[0].value = all; 
        })
        
        $(".c").click(function ()
        {
            all = " ";
            $(".screen")[0].value =all;
        })
        
        $(".ce").click(function ()
        {
            all = $(".screen")[0].value.slice(0,-1); 
            $(".screen")[0].value = all;
        })
        
        
        
       

    }
)