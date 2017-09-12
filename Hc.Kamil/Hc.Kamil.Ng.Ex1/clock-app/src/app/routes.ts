import { ListModalComponent } from './list-modal/list-modal.component';
import { ListComponent } from './persons/components/list/list.component';
import { PersonFormComponent } from './persons/components/person-form/person-form.component';
import { ClockComponent } from './clock/clock.component';

export const HeadRoutes = [
  { path: 'person-form', component: PersonFormComponent },
  { path: 'modal', component: ListModalComponent },
  { path: '', redirectTo: '/person-form', pathMatch: 'full' }
];
