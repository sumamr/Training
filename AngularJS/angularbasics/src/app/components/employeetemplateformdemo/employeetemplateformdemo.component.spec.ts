import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeetemplateformdemoComponent } from './employeetemplateformdemo.component';

describe('EmployeetemplateformdemoComponent', () => {
  let component: EmployeetemplateformdemoComponent;
  let fixture: ComponentFixture<EmployeetemplateformdemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmployeetemplateformdemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EmployeetemplateformdemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
