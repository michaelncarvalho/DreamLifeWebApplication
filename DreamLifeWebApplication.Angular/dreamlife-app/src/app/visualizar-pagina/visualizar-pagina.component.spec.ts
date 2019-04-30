import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VisualizarPaginaComponent } from './visualizar-pagina.component';

describe('VisualizarPaginaComponent', () => {
  let component: VisualizarPaginaComponent;
  let fixture: ComponentFixture<VisualizarPaginaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VisualizarPaginaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VisualizarPaginaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
