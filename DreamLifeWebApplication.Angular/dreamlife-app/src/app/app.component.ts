import { Component, Input, OnInit} from '@angular/core';
import { TripService } from './trips/trip/trip.service';
import { MatDialog } from '@angular/material';
import { Trip } from './trips/trip/trip';
import { MatMenuModule } from '@angular/material/menu';
import { AppMaterialModule } from './app-material/app-material.module';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {  

  /*constructor(http: HttpClient) {
     http
     .get<Object[]>('http://localhost:50214/trips/Viagens')
     .subscribe(trips => this.trips = trips);
     //.subscribe(trips => console.log(trips));
  } */

  constructor(public dialog: AppMaterialModule) {  }
  

}
