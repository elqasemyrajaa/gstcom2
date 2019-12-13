import { TestBed } from '@angular/core/testing';

import { StatutResolverService } from './statut-resolver.service';

describe('StatutResolverService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: StatutResolverService = TestBed.get(StatutResolverService);
    expect(service).toBeTruthy();
  });
});
