import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LeavesForAnEmployeeComponent } from './leaves-for-an-employee.component';

describe('LeavesForAnEmployeeComponent', () => {
  let component: LeavesForAnEmployeeComponent;
  let fixture: ComponentFixture<LeavesForAnEmployeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LeavesForAnEmployeeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeavesForAnEmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
