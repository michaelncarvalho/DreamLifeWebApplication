import { Component, ViewEncapsulation } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'descricao-hotel',
  templateUrl: './descricao-hotel.component.html',
  encapsulation: ViewEncapsulation.None,
  styles: [`
    .dark-modal .modal-content {
      background-color: #292b2c;
      color: white;
    }
    .dark-modal .close {
      color: white;
    }
    .light-blue-backdrop {
      background-color: #5cb3fd;
    }
  `]
})
export class DescricaoHotelComponent {
  closeResult: string;

  constructor(private modalService: NgbModal) {}
  
  openVerticallyCentered(content) {
    this.modalService.open(content, { centered: true });
  }
}
