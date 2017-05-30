import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {
  developer: string;
  year: number;

  constructor() { }

  ngOnInit() {
    this.developer = 'Kamil Wołczyk';
    this.year = new Date().getFullYear();
  }
}
