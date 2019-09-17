/// <reference types="Cypress" />

import { blog } from '../../support/objects';

describe('Blog Setup', function() {
    it('Setup blog tenant  tenants', function() {
        cy.login();
        cy.createTenant(blog);
        cy.gotoTenantSetup(blog);
        cy.setupSite(blog);
    });
});
