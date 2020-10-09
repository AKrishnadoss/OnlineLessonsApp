import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HomeComponent } from './app/components/home/home.component';
import { ContactUsComponent } from './app/components/contactus/contactus.component';
import { EventsComponent } from './app/components/events/events.component';
import { ParentsComponent } from './app/components/parents/parents.component';
import { StudentsComponent } from './app/components/students/students.component';
import { HistoryComponent } from './app/components/history/history.component';


export const AppRoutes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: "home", component: HomeComponent },
  { path: "contactus", component: ContactUsComponent },
  { path: "events", component: EventsComponent },
  { path: "history", component: HistoryComponent },
  { path: "parents", component: ParentsComponent },
  { path: "students", component: StudentsComponent },
  { path: "**", redirectTo: 'home', pathMatch: 'full' }

  // TODO: Session timed out or Unauthorized access
  //{ path : "contactus", component: ContactComponent}
]

@NgModule({
  imports: [RouterModule.forRoot(AppRoutes, { useHash: true, enableTracing: false })],
  exports: [RouterModule]
})

export class AppRoutingModule {

}
