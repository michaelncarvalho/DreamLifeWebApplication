import { Component, Input } from "@angular/core";

@Component({
    selector: 'ap-trip',
    templateUrl: 'trip.component.html'
})
export class TripComponent {
    
    @Input() Id = '';

    @Input() HotelId='';
    
    @Input() Data='';

    @Input() ModalidadeViagem='';

    @Input() QuantidadePessoas='';
}
