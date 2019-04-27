import { Component, Input} from "@angular/core";
import { Trip } from "./trip";
import { BehaviorSubject } from "rxjs";
import { TripService } from "./trip.service";

@Component({
    selector: 'ap-trip',
    templateUrl: 'trip.component.html',
    styleUrls: ['./trip.component.css']
})

export class TripComponent {   
    
      
    @Input() trips: Trip[];

    constructor(private tripService: TripService) {   }

    ngOnInit() {
        this.tripService
      .getTrips()
      .subscribe(trips => {        
        this.trips = trips
        console.log(this.trips)
      });
     }
    
}


