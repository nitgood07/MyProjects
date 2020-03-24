import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LeaveViewsComponent } from './leave-views.component';

describe('LeaveViewsComponent', () => {
  let component: LeaveViewsComponent;
  let fixture: ComponentFixture<LeaveViewsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LeaveViewsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeaveViewsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
