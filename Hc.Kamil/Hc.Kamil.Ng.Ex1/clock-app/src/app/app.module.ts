import { PersonService } from './persons/services/person.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { FooterComponent } from './layout/footer/footer.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';
import { ClockComponent } from './clock/clock.component';
import { RootComponent } from './root/root.component';
import { MemberListComponent } from './test/member-list/member-list.component';
import { ListComponent } from './persons/components/list/list.component';
import { SudokuComponent } from './sudoku/sudoku.component';
import { PersonFormComponent } from './persons/components/person-form/person-form.component';
import { ListModalComponent } from './list-modal/list-modal.component';
import { HeadRoutes } from "app/routes";
import { NavigationComponent } from './layout/navigation/navigation.component';

@NgModule({
  declarations: [
    RootComponent,
    FooterComponent,
    TopBarComponent,
    ClockComponent,
    MemberListComponent,
    ListComponent,
    SudokuComponent,
    PersonFormComponent,
    ListModalComponent,
    NavigationComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot(HeadRoutes)
  ],
  providers: [
    PersonService
  ],
  bootstrap: [RootComponent]
})
export class AppModule { }
