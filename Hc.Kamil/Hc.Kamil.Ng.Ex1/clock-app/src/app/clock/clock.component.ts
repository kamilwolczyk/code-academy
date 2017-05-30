import { ClockConfiguration, ClockType } from './clockConfiguration';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-clock',
  templateUrl: './clock.component.html',
  styleUrls: ['./clock.component.css']
})
export class ClockComponent implements OnInit {
  clockCssClass: string;
  currentTime: string;
  separator = ':';
  @Input() configuration: ClockConfiguration;

  ngOnInit() {
    this.clockCssClass = this.getCssClass(this.configuration.type);

    this.refreshTime();
    setInterval(() => this.refreshTime(), 1000);
  }

  refreshTime() {
    const date = new Date();
    const hours = this.formatTimeNumber(date.getHours());
    const minutes = this.formatTimeNumber(date.getMinutes());
    const seconds = this.formatTimeNumber(date.getSeconds());

    const lastPart = this.configuration.displaySeconds ? ` ${this.separator} ${seconds}` : '';

    this.currentTime = `${hours} ${this.separator} ${minutes}${lastPart}`;
  }

  private formatTimeNumber(value: number) {
    return value < 10 ? `0${value}` : value;
  }

  private getCssClass(type: ClockType): string {
    switch (this.configuration.type) {
      case ClockType.Small: return 'small';
      case ClockType.Medium: return 'medium';
      case ClockType.Large: return 'large';
      default: return '';
    }
  }

}
