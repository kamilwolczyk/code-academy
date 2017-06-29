import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule} from '@angular/router';

import { AppComponent } from './root/app.component';
import { FooterComponent } from './layout/footer/footer.component';
import { TopBarComponent } from './layout/top-bar/top-bar.component';
import { ClockComponent } from './clock/clock.component';
import { MemberListComponent } from './test/member-list/member-list.component';
import { PersonTableComponent } from './person/components/person-table/person-table.component';
import { PersonFormComponent } from './person/components/person-form/person-form.component';
import { ListModalComponent } from './list-modal/list-modal.component';
import { PersonService } from "app/person/services/person.service";
import { HeadRoutes } from "app/routes";
import { NavigationComponent } from './layout/navigation/navigation.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    TopBarComponent,
    ClockComponent,
    MemberListComponent,
    PersonTableComponent,
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
  bootstrap: [AppComponent]
})
export class AppModule { }
