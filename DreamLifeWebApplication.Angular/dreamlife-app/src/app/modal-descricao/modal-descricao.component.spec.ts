import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModalDescricaoComponent } from './modal-descricao.component';

describe('ModalDescricaoComponent', () => {
  let component: ModalDescricaoComponent;
  let fixture: ComponentFixture<ModalDescricaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModalDescricaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModalDescricaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
