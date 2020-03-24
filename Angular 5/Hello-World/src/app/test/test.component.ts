import { Component, OnInit } from '@angular/core';
import { getCurrencySymbol } from '@angular/common';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styles: [` 
            .text-success{
              color:green;
            }
            .text-danger{
              color:red;
            }
            .text-special{
              font-style: italic;
            }
          `]
})
export class TestComponent implements OnInit {

  public name = "Nitin";
  //property binding
  public isDisabled = false;
  public isDisabled2 = true;

  //style class binding
  public hasError = true;
  public isSpecial = false;
  public messageClass = {
    "text-success": !this.hasError,
    "text-danger": this.hasError,
    "text-special": this.isSpecial
  }


  //style binding
  public styleSetColor = "yellow";
  public styleClass = {
    fontFamily:"Arial",
    color:"green",
    fontStyle:"italic"
  }

  constructor() { }


  ngOnInit() {
  }

  GreetUser(){
    return "I am coming from " + this.name;
  }

  OnClick(event){
    //click event raised from view/html
    console.log(event);
    //change property value on click event
    this.styleSetColor = (this.styleSetColor == "yellow") ? "blue": "yellow";
  }

  //template reference variables
  logMessage(value){
    console.log(value);
  }

  logMessage2(value){
    console.log(value);
  }

}
