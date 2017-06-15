import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { FooterComponent } from './layout/footer/footer.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';
import { ClockComponent } from './clock/clock.component';
import { RootComponent } from './root/root.component';
import { MemberListComponent } from './test/member-list/member-list.component';
import { ListComponent } from './persons/components/list/list.component';
import { SudokuComponent } from './sudoku/sudoku.component';
import { PersonFormComponent } from './persons/components/person-form/person-form.component';

@NgModule({
  declarations: [
    RootComponent,
    FooterComponent,
    TopBarComponent,
    ClockComponent,
    MemberListComponent,
    ListComponent,
    SudokuComponent,
    PersonFormComponent
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
