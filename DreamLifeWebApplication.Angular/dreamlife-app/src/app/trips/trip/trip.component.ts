import { Component, Input, ViewChild, SimpleChanges } from "@angular/core";
import { Trip } from "./trip";
import { TripService } from "./trip.service";
import { NgbModal } from "@ng-bootstrap/ng-bootstrap";
import { MenuDescricaoComponent } from "src/app/menu-descricao/menu-descricao.component";


@Component({
  selector: 'ap-trip',
  templateUrl: 'trip.component.html',
  styleUrls: ['./trip.component.css']
})

export class TripComponent {

  @Input() trips: Trip[] = [];
  @Input() hotelIdModel: number;
 

  constructor(private tripService: TripService, private modalService: NgbModal) { }

  
 selectedValue: string;
  
 receiveMessage($event) {
  this.selectedValue = $event;
  this.tripService
  .getTrips(this.selectedValue)
  .subscribe(trips => {
    this.trips = trips
    console.log(this.trips)
  });
}

  ngOnInit() {

  }

  openVerticallyCentered(content) {
    this.modalService.open(content, { 
      size: 'lg',
      centered: true,
    });
  }


}



