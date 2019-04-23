import {Component, Input} from "@angular/core";

@Component ({
    selector: 'ap-trip',
    templateUrl: 'trip.component.html'
})

export class TripComponent {
    @Input() description='';
    
    @Input() url='';
}
