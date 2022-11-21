import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplateformdemoComponent } from './templateformdemo.component';

describe('TemplateformdemoComponent', () => {
  let component: TemplateformdemoComponent;
  let fixture: ComponentFixture<TemplateformdemoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TemplateformdemoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemplateformdemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
