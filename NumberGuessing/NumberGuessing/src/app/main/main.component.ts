import { Component, Input, ChangeDetectionStrategy } from '@angular/core';
import { TestBed } from '@angular/core/testing';
import { areAllEquivalent } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'main',
  templateUrl: './main.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})

export class MainComponent {
  randomNumber = Math.floor(Math.random() * 100) + 1;
  inputNumber: any;
  numberArray:Array<number> = new Array<number>();
  viewReset:boolean = false;
  guildMessage:string = "";  
  guessCount = 0;

  constructor(){  }

  public checkGuess() {
    this.guessCount++;
    let checkNum: any = (<HTMLInputElement>document.getElementById("guessField")).value;

    if(isNaN(checkNum) || checkNum <= 0 || checkNum > 100) {
      alert("잘못된 입력입니다.");
      return;
    }

    if(this.guessCount > 10) {
      this.failGuess();
      return;
    }
    
    this.inputNumber = checkNum;      
    this.checkInputText(checkNum);    
  }

  public resetQuest() {
    this.inputNumber = null;
    this.numberArray = [];
    this.viewReset = false;
    this.guildMessage = "";
    this.guessCount = 0;
    this.randomNumber = Math.floor(Math.random() * 100) + 1;
  }

  public checkInputText(num: number){
    this.numberArray.push(num);
    if(this.randomNumber == num) {
      this.successGuess();
      return;
    }
    if(this.randomNumber > num) {
      this.guildMessage = "입력한 숫자가 더 작습니다."
      return;
    }    
    if(this.randomNumber < num) {
      this.guildMessage = "입력한 숫자가 더 큽니다."
      return;
    }
  }

  public successGuess() {
    this.guildMessage = "정답입니다. 다시 도전하시려면 reset버튼을 눌러주세요."
    this.viewReset = true;
  }

  public failGuess() {
    this.guildMessage = "실패입니다. 다시 도전을 원하시면 reset버튼을 눌러주세요."
    this.viewReset = true;
  }
}

