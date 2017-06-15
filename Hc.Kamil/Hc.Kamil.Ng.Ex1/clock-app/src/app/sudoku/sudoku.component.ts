import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sudoku',
  templateUrl: './sudoku.component.html',
  styleUrls: ['./sudoku.component.css']
})
export class SudokuComponent implements OnInit {

  row: number = 19;
  collection: number[][];

  constructor() { }

  ngOnInit() {
    this.collection = [];

    for (var i = 0; i < 10; i++) {
      var row = [];
      for (var j = 0; j < 10; j++) {
        row.push(i * j);
      }
      this.collection.push(row);
    }
  }

}
