import { Component } from '@angular/core';
import { TripService } from './trips/trip/trip.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  trips: Object[] = [];

  /*constructor(http: HttpClient) {
     http
     .get<Object[]>('http://localhost:50214/trips/Viagens')
     .subscribe(trips => this.trips = trips);
     //.subscribe(trips => console.log(trips));
  } */

  constructor(tripService: TripService){
    tripService
    .getTrips()
    .subscribe(trips => { 
      console.log(trips)
      this.trips = trips
    });
  }
}
