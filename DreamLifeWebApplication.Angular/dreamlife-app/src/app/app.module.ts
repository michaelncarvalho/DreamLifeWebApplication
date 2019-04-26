import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MatDialogModule} from '@angular/material/dialog';
import {MatMenuModule} from '@angular/material/menu';



import { AppComponent } from './app.component';
import { TripsModule } from './trips/trips.module';

import { AppMaterialModule } from './app-material/app-material.module';
import { DescricaoHotelComponent } from './descricao-hotel/descricao-hotel.component';
import { TripComponent } from './trips/trip/trip.component';

@NgModule({
  declarations: [
    AppComponent,
    DescricaoHotelComponent
  ],
  imports: [
    BrowserModule,
    TripsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatDialogModule, 
    MatMenuModule,
    AppMaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
