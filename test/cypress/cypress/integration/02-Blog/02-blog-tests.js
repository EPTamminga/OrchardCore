/// <reference types="Cypress" />

import faker from 'faker';
import { blog } from '../../support/objects';

describe('Blog Tests', function() {
    it('Can add blog post and it displays in the frontend', function() {
        cy.login(blog);
        cy.visitAdmin(blog);
        // blog admin menu
        cy.get('li.icon-class-fa-rss > .item-label > .title').click();
        // create blog post button
        cy.get('p > .btn.btn-primary').click();

        var blogName = faker.random.uuid();
        // fill form
        cy.get('#TitlePart_Title').type(blogName);
        var text = faker.lorem.sentence();
        cy.get('.CodeMirror textarea')
            // we use `force: true` below because the textarea is hidden
            // and by default Cypress won't interact with hidden elements
            .type(text, { force: true });

        // click publish button
        cy.get('.btn-success').click();

        cy.visitTenantPage(blog, `blog/${blogName}`);

        cy.contains('h1').should('contain.text', blogName);
        cy.get(':nth-child(3) > .row > .col-lg-8 > p').should('contain.text', text);
    });
});
