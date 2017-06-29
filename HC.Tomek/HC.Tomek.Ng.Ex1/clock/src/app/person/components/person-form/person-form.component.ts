import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-person-form',
  templateUrl: './person-form.component.html',
  styleUrls: ['./person-form.component.css']
})
export class PersonFormComponent implements OnInit {

  constructor() { }
  firstName: string = "Kamil";
  lastName: string = "Wolczyk";
  ngOnInit() {
  }
  addPerson(){
    alert(`Dodałeś nową osobę: ${this.firstName} ${this.lastName}`)
  }

}
