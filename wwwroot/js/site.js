// Ingredient checklist toggle
document.querySelectorAll('.ingredient-check').forEach(checkbox => {
    checkbox.addEventListener('change', function () {
        const span = this.nextElementSibling;
        if (this.checked) {
            span.style.textDecoration = 'line-through';
            span.style.opacity = '0.5';
        } else {
            span.style.textDecoration = '';
            span.style.opacity = '';
        }
    });
});

// Fade-in on scroll
const observer = new IntersectionObserver((entries) => {
    entries.forEach(e => {
        if (e.isIntersecting) {
            e.target.style.opacity = '1';
            e.target.style.transform = 'translateY(0)';
        }
    });
}, { threshold: 0.12 });

document.querySelectorAll('.recipe-card, .tip-card, .tip-card-full, .category-card, .step-item').forEach(el => {
    el.style.opacity = '0';
    el.style.transform = 'translateY(20px)';
    el.style.transition = 'opacity .4s ease, transform .4s ease';
    observer.observe(el);
});
