import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LeavesForAMonthComponent } from './leaves-for-amonth.component';

describe('LeavesForAMonthComponent', () => {
  let component: LeavesForAMonthComponent;
  let fixture: ComponentFixture<LeavesForAMonthComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LeavesForAMonthComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeavesForAMonthComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
