import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DescricaoHotelComponent } from './descricao-hotel.component';

describe('DescricaoHotelComponent', () => {
  let component: DescricaoHotelComponent;
  let fixture: ComponentFixture<DescricaoHotelComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DescricaoHotelComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DescricaoHotelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
