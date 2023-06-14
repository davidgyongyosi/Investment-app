import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CoinTableComponent } from './components/coin-table/coin-table.component';
import { PagenotfoundComponent } from './components/pagenotfound/pagenotfound.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthGuard } from './services/auth.guard';
import { ProfileComponent } from './components/profile/profile.component';

const routes: Routes = [
  { path: 'home', component: CoinTableComponent},
  { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard]},
  { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard]},
  { path: '',   redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: PagenotfoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(
      routes,
      { enableTracing: false }
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
