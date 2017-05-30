import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { FooterComponent } from './layout/footer/footer.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';
import { ClockComponent } from './clock/clock.component';
import { RootComponent } from './root/root.component';

@NgModule({
  declarations: [
    RootComponent,
    FooterComponent,
    TopBarComponent,
    ClockComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [RootComponent]
})
export class AppModule { }
