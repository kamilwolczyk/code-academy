import { Component, OnInit, Input } from '@angular/core';
import { Person } from "app/person/models/person";

@Component({
  selector: 'app-person-table',
  templateUrl: './person-table.component.html',
  styleUrls: ['./person-table.component.css']
})
export class PersonTableComponent implements OnInit {

  @Input() personTable: Person[];
  constructor() { }

  ngOnInit() {
    
    //this.personTable.push(person);
  }


}
