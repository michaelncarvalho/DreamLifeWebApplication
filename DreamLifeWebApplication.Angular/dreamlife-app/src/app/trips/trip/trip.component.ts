import { Component, Input} from "@angular/core";
import { Trip } from "./trip";
import { BehaviorSubject } from "rxjs";

@Component({
    selector: 'ap-trip',
    templateUrl: 'trip.component.html'
})

export class TripComponent {   
    
      
    @Input() 
    listaHoteis: Trip[];

    constructor() {   }

   
    
}


