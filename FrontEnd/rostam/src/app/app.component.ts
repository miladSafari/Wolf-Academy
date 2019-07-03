import { Component } from '@angular/core';
import { getLocaleDateTimeFormat } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.sass']
})
export class AppComponent {
  numbers:Array<string>;
  constructor(){
    this.numbers=new Array<string>();
  }
  addItem():void{
    let random=Math.floor(Math.random() * 100) + 1;
    this.numbers.push(random.toString());
  }
}
