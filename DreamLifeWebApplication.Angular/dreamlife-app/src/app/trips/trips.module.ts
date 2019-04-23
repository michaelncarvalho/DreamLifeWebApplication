import { NgModule } from "@angular/core";
import { TripComponent } from "./trip/trip.component";


@NgModule({
    declarations: [ TripComponent ],
    exports: [ TripComponent ]
})

export class TripsModule { }