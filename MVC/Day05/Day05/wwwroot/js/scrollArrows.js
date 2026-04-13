function setupScrollToTop(elementId) {
    const btn = document.getElementById(elementId);
    if (!btn) return;

    btn.addEventListener('click', () => {
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });

    window.addEventListener('scroll', () => {
        if (window.scrollY > 200) {
            btn.style.opacity = '1';
            btn.style.transform = 'scale(1)';
            btn.style.pointerEvents = 'auto';
        } else {
            btn.style.opacity = '0';
            btn.style.transform = 'scale(0.8)';
            btn.style.pointerEvents = 'none';
        }
    });

    // Initial state
    if (window.scrollY <= 200) {
        btn.style.opacity = '0';
        btn.style.transform = 'scale(0.8)';
        btn.style.pointerEvents = 'none';
    }
}

function setupScrollToBottom(elementId) {
    const btn = document.getElementById(elementId);
    if (!btn) return;

    btn.addEventListener('click', () => {
        window.scrollTo({
            top: document.documentElement.scrollHeight,
            behavior: 'smooth'
        });
    });

    window.addEventListener('scroll', () => {
        const scrolledToBottom = window.innerHeight + window.scrollY >= document.documentElement.scrollHeight - 200;
        if (!scrolledToBottom) {
            btn.style.opacity = '1';
            btn.style.transform = 'scale(1)';
            btn.style.pointerEvents = 'auto';
        } else {
            btn.style.opacity = '0';
            btn.style.transform = 'scale(0.8)';
            btn.style.pointerEvents = 'none';
        }
    });

    // Initial state
    const scrolledToBottom = window.innerHeight + window.scrollY >= document.documentElement.scrollHeight - 200;
    if (scrolledToBottom) {
        btn.style.opacity = '0';
        btn.style.transform = 'scale(0.8)';
        btn.style.pointerEvents = 'none';
    }
}
