import { Component, ViewEncapsulation } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'modal-descricao',
  templateUrl: './modal-descricao.component.html',
  encapsulation: ViewEncapsulation.None,

})
export class ModalDescricaoComponent {
  closeResult: string;

  constructor(private modalService: NgbModal) {}
  
  openVerticallyCentered(content) {
    this.modalService.open(content, { centered: true });
  }
}
