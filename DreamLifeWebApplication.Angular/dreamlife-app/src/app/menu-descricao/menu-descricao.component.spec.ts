import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuDescricaoComponent } from './menu-descricao.component';

describe('MenuDescricaoComponent', () => {
  let component: MenuDescricaoComponent;
  let fixture: ComponentFixture<MenuDescricaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MenuDescricaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MenuDescricaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
