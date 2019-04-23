import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { TripsModule } from './trips/trips.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    TripsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
