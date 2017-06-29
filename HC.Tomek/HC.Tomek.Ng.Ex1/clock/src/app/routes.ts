import { ClockComponent } from "app/clock/clock.component";
import { PersonFormComponent } from "app/person/components/person-form/person-form.component";
import { ListModalComponent } from "app/list-modal/list-modal.component";

export const HeadRoutes = [
    {path: 'clock', component: ClockComponent},
    {path: 'person-form', component: PersonFormComponent},
    {path: 'modal', component: ListModalComponent},
    {path: '', redirectTo: 'clock', pathMatch: 'full'}
];