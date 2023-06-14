import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { AuthInterceptor } from './services/auth.interceptor';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { CoinTableComponent } from './components/coin-table/coin-table.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { RegistrationComponent } from './components/auth-forms/registration.component';
import { LoginComponent } from './components/auth-forms/login.component';
import { SidenavComponent } from './components/sidenav/sidenav.component';
import { PagenotfoundComponent } from './components/pagenotfound/pagenotfound.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { ProfileComponent } from './components/profile/profile.component';
import { AddcoinModalComponent } from './components/addcoin-modal/addcoin-modal.component';
import { EditcoinModalComponent } from './components/editcoin-modal/editcoin-modal.component';

//Angular Material imports
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';
import { MatDialogModule } from '@angular/material/dialog';
import { MatSidenavModule } from '@angular/material/sidenav';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {MatGridListModule} from '@angular/material/grid-list';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import { AddCoinComponent } from './components/add-coin/add-coin.component';
import { EditCoinComponent } from './components/edit-coin/edit-coin.component';
import { TreemapComponent } from './components/treemap/treemap.component';



@NgModule({
  declarations: [
    AppComponent,
    CoinTableComponent,
    NavbarComponent,
    RegistrationComponent,
    LoginComponent,
    SidenavComponent,
    PagenotfoundComponent,
    DashboardComponent,
    ProfileComponent,
    AddcoinModalComponent,
    EditcoinModalComponent,
    AddCoinComponent,
    EditCoinComponent,
    TreemapComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTableModule,
    MatSortModule,
    MatPaginatorModule,
    MatFormFieldModule,
    MatInputModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    MatMenuModule,
    MatDialogModule,
    MatSidenavModule,
    ReactiveFormsModule,
    MatGridListModule,
    MatSnackBarModule,
    MatAutocompleteModule,
    MatProgressBarModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true,
    },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
