import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MemberListTestsComponent } from './member-list-tests.component';

describe('MemberListTestsComponent', () => {
  let component: MemberListTestsComponent;
  let fixture: ComponentFixture<MemberListTestsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MemberListTestsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MemberListTestsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
