import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {
  names: string[];
  isRaining: boolean;

  ngOnInit() {
    this.names = [
      'Gosia',
      'Tomek',
      'Jacek',
      'Kamil'
    ];

    this.isRaining = true;
  }

}
