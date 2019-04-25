import { Component } from '@angular/core';
import { TripService } from './trips/trip/trip.service';
import {MatDialog} from '@angular/material';
import { Trip } from './trips/trip/trip';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  trips: Trip[] = [];

  /*constructor(http: HttpClient) {
     http
     .get<Object[]>('http://localhost:50214/trips/Viagens')
     .subscribe(trips => this.trips = trips);
     //.subscribe(trips => console.log(trips));
  } */

  constructor(tripService: TripService, public dialog: MatDialog){
    tripService
    .getTrips()
    .subscribe(trips => { 
      console.log(trips)
      this.trips = trips
    });    
  }

  openDialog() {
    const dialogRef = this.dialog.open(AppComponent, {
      height: '350px'
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }
}
