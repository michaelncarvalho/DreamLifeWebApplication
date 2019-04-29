import { Component, Input } from "@angular/core";
import { Trip } from "./trip";
import { TripService } from "./trip.service";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";


@Component({
  selector: 'ap-trip',
  templateUrl: 'trip.component.html',
  styleUrls: ['./trip.component.css']
})

export class TripComponent {

  @Input() trips: Trip[];
  @Input() hotelIdModel: number;


  constructor(private tripService: TripService, private modalService: NgbModal) { }


  ngOnInit() {
    this.tripService
      .getTrips()
      .subscribe(trips => {
        this.trips = trips
        console.log(this.trips)
      });
  }
  openVerticallyCentered(content) {
    this.modalService.open(content, { 
      size: 'lg',
      centered: true,
    });
  }

}



