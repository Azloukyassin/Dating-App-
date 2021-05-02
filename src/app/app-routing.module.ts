import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MemberDetailComponent } from './member-detail/member-detail.component';
import { MemberListTestsComponent } from './member-list-tests/member-list-tests.component';
import { MessageComponent } from './message/message.component';
import { AuthGuard } from './_gurads/auth.guard';
const routes: Routes = [
  {path:'' , component:HomeComponent},
  {
    path:'',
    runGuardsAndResolvers:'always', 
    canActivate:[AuthGuard], 
    children: [
      {path:'members' , component:MemberListTestsComponent , canActivate: [AuthGuard]},
      {path:'member/id' , component:MemberDetailComponent},
      {path:'liste' , component:ListsComponent},
      {path:'messages' , component:MessageComponent},
    ]
  },
  {path:'**' , component:HomeComponent,pathMatch:"full"},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
