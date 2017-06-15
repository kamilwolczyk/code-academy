import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-person-form',
  templateUrl: './person-form.component.html',
  styleUrls: ['./person-form.component.css']
})
export class PersonFormComponent implements OnInit {
  firstName: string;
  lastName: string;

  constructor() { }

  ngOnInit() {
  }

  addPerson() {
    alert(`Dodałeś nową osobę: ${this.firstName} ${this.lastName}`);
    this.firstName = '';
    this.lastName = '';
  }

}
